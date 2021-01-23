using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using TestWebShop.Models;

namespace TestWebShop.Test.Context
{
    //internal class FakeDbSet<TEntity> : DbSet<TEntity>, IQueryable
    //    , IEnumerable<TEntity>, IDbAsyncEnumerable<TEntity>
    //    where TEntity : BaseEntity
    //{
    //    private readonly ObservableCollection<TEntity> _data;
    //    private readonly IQueryable _query;

    //    public FakeDbSet()
    //    {
    //        _data = new ObservableCollection<TEntity>();
    //        _query = _data.AsQueryable();
    //    }

    //    public override ObservableCollection<TEntity> Local => _data;

    //    IDbAsyncEnumerator<TEntity> IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator()
    //    {
    //        return new TestDbAsyncEnumerator<TEntity>(_data.GetEnumerator());
    //    }

    //    IEnumerator<TEntity> IEnumerable<TEntity>.GetEnumerator()
    //    {
    //        return _data.GetEnumerator();
    //    }

    //    Type IQueryable.ElementType => _query.ElementType;

    //    Expression IQueryable.Expression => _query.Expression;

    //    IQueryProvider IQueryable.Provider => new TestDbAsyncQueryProvider<TEntity>(_query.Provider);

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return _data.GetEnumerator();
    //    }

    //    public override TEntity Add(TEntity item)
    //    {
    //        item.Id = _data.Count;
    //        _data.Add(item);
    //        return item;
    //    }

    //    public override IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities)
    //    {
    //        foreach (var item in entities)
    //        {
    //            item.Id = _data.Count;
    //            _data.Add(item);
    //        }

    //        return entities;
    //    }

    //    public override TEntity Remove(TEntity item)
    //    {
    //        _data.Remove(item);
    //        return item;
    //    }

    //    public override TEntity Attach(TEntity item)
    //    {
    //        _data.Add(item);
    //        return item;
    //    }

    //    public override TEntity Create()
    //    {
    //        return Activator.CreateInstance<TEntity>();
    //    }

    //    public override TDerivedEntity Create<TDerivedEntity>()
    //    {
    //        return Activator.CreateInstance<TDerivedEntity>();
    //    }
    //}

    //internal class TestDbAsyncEnumerable<T> : EnumerableQuery<T>, IDbAsyncEnumerable<T>, IQueryable<T>
    //{
    //    public TestDbAsyncEnumerable(IEnumerable<T> enumerable)
    //        : base(enumerable)
    //    {
    //    }

    //    public TestDbAsyncEnumerable(Expression expression)
    //        : base(expression)
    //    {
    //    }

    //    public IDbAsyncEnumerator<T> GetAsyncEnumerator()
    //    {
    //        return new TestDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
    //    }

    //    IDbAsyncEnumerator IDbAsyncEnumerable.GetAsyncEnumerator()
    //    {
    //        return GetAsyncEnumerator();
    //    }

    //    IQueryProvider IQueryable.Provider => new TestDbAsyncQueryProvider<T>(this);
    //}

    //internal class TestDbAsyncEnumerator<T> : IDbAsyncEnumerator<T>
    //{
    //    private readonly IEnumerator<T> _inner;

    //    public TestDbAsyncEnumerator(IEnumerator<T> inner)
    //    {
    //        _inner = inner;
    //    }

    //    public void Dispose()
    //    {
    //        _inner.Dispose();
    //    }

    //    public Task<bool> MoveNextAsync(CancellationToken cancellationToken)
    //    {
    //        return Task.FromResult(_inner.MoveNext());
    //    }

    //    public T Current => _inner.Current;

    //    object IDbAsyncEnumerator.Current => Current;
    //}
}