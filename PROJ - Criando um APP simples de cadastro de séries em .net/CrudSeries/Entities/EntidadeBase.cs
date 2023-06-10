using System;

namespace CrudSeries.Entities
{
    public abstract class EntidadeBase
    {

        public int Id { get; set; }
        
       /* public Guid Id { get; protected set; }

        public EntidadeBase()
        {
            Id = Guid.NewGuid();
        }
        */
    }
}