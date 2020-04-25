using System;

namespace WebApp.Data.Interfaces
{
    public interface IDateTracking
    {
         DateTime DateCreated {set;get;}
         DateTime DateModified {set;get;}
    }
}