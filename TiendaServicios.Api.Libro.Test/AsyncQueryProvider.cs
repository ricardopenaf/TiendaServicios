using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TiendaServicios.Api.Libro.Test
{
    public class AsyncQueryProvider<TEntity> : IAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        public AsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(Expression expression)
        {
           return new TestAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            return new TestAsyncEnumerable<TElement>(expression);
        }

        public object? Execute(Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(Expression expression)
        {
            return _inner.Execute<TResult>(expression);
        }

        public TResult ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken = default)
        {
            var resultType = typeof(TResult).GetGenericArguments()[0];

            var executeMethod = typeof(IQueryProvider)
                .GetMethod(
                    name: nameof(IQueryProvider.Execute),
                    genericParameterCount: 1,
                    types: new[] { typeof(Expression) })
                ?? throw new InvalidOperationException($"No se encontró el método {nameof(IQueryProvider.Execute)} en {nameof(IQueryProvider)}.");

            var executionResult = executeMethod
                .MakeGenericMethod(resultType)
                .Invoke(this, new[] { expression });

            var fromResultMethod = typeof(Task).GetMethod(nameof(Task.FromResult))
                ?? throw new InvalidOperationException($"No se encontró el método {nameof(Task.FromResult)} en {nameof(Task)}.");

            return (TResult)fromResultMethod
                .MakeGenericMethod(resultType)
                .Invoke(null, new[] { executionResult })!;
        }
    }
}
