﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Repository
{
    public class ActivityRepository : IActivityRepository
    {
        private MyDbContext _db;


        public ActivityRepository(MyDbContext dbContext)
        {
            _db = dbContext;
        }

        public void Add(Activity activity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Activity> GetAll()
        {
            return _db.Activities.AsNoTracking().ToList();
        }

        public Activity Find(int key)
        {
            return _db.Activities.AsNoTracking().FirstOrDefault(a => a.ActivityID == key);
        }

        public bool CheckValidUserKey(string reqkey)
        {
            throw new System.NotImplementedException();
        }
    }
}