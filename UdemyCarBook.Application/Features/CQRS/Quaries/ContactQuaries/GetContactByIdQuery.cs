using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Quaries.ContactQuaries
{
    public class GetContactByIdQuery
    {
        public GetContactByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
