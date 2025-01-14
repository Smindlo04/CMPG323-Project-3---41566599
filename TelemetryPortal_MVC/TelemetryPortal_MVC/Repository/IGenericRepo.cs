﻿using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq.Expressions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace TelemetryPortal_MVC.Repository
{
    public interface IGenericRepo<T> where T : class
    {
        T GetByID (int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add (T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove (T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
