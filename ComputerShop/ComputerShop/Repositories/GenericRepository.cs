using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ComputerShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ComputerShop.Repositories
{
    public class GenericRepository<T> where T:class,new() //T mutlaka bir class olmalı ve new anahtar sözcüğünü barındırmalı
    {
        Context c = new Context();
        public List<T> TList(){
            return c.Set<T>().ToList();
        }
         public List<T> TList(string p){
            return c.Set<T>().Include(p).ToList();
        }
        public void TAdd(T p){
            c.Set<T>().Add(p);
            c.SaveChanges();
        }
        public void TDelete(T p){
            c.Set<T>().Remove(p);
            c.SaveChanges();
        }
        public void TUpdate(T p){
            c.Set<T>().Update(p);
            c.SaveChanges();
        }
        public T TGet(int id){
           return c.Set<T>().Find(id);
        }
        public List<T> List(Expression<Func<T, bool>> filter){ //istediğim herhangi bir ürün üzerinde arama yapabilirim
            return c.Set<T>().Where(filter).ToList();
        }
       
    }
}