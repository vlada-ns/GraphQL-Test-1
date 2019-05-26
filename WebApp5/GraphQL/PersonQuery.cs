using GraphQL;
using GraphQL.Types;
using System.Collections.Generic;
using System.Security.Claims;
using WebApp5.GraphQL.Types;
using WebApp5.Models;
using WebApp5.Repository;

namespace WebApp5.GraphQL
{
    public class PersonQuery : ObjectGraphType
    {
        public PersonQuery(PersonRepository personRepository)
        {
            /*Version: 1 get all*/
            Field<ListGraphType<PersonType>>("persons",
                resolve: context => personRepository.GetAll());

            /*Version: 2 filtering*/
            //Field<ListGraphType<PersonType>>("persons",
            //    arguments: new QueryArguments(new List<QueryArgument>
            //    {
            //        new QueryArgument<IdGraphType>
            //        {
            //            Name = "id"
            //        },
            //        new QueryArgument<StringGraphType>
            //        {
            //            Name = "name"
            //        }
            //    }),
            //    resolve: context =>
            //    {
            //        var query = personRepository.GetAll();

            //        var user = (ClaimsPrincipal)context.UserContext;
            //        var isUserAuthenticated = ((ClaimsIdentity)user.Identity).IsAuthenticated;

            //        var personId = context.GetArgument<int?>("id");
            //        if (personId.HasValue)
            //        {
            //            if (personId.Value <= 0)
            //            {
            //                context.Errors.Add(new ExecutionError("personId must be greater than zero!"));
            //                return new List<Person>();
            //            }

            //            return personRepository.GetAll()/*.Where(p => p.Id == personId.Value)*/;
            //        }

            //        return query;
            //    }
            //);

            /*Version: 2 filtering*/
            //Field<ListGraphType<ReservationType>>("reservations",
            //    arguments: new QueryArguments(new List<QueryArgument>
            //    {
            //        new QueryArgument<IdGraphType>
            //        {
            //            Name = "id"
            //        },
            //        new QueryArgument<DateGraphType>
            //        {
            //            Name = "checkinDate"
            //        },
            //        new QueryArgument<DateGraphType>
            //        {
            //            Name = "checkoutDate"
            //        },
            //        new QueryArgument<BooleanGraphType>
            //        {
            //            Name = "roomAllowedSmoking"
            //        },
            //        new QueryArgument<RoomStatusType>
            //        {
            //            Name = "roomStatus"
            //        }
            //    }),
            //    resolve: context =>
            //    {
            //        var query = reservationRepository.GetQuery();

            //        var user = (ClaimsPrincipal)context.UserContext;
            //        var isUserAuthenticated = ((ClaimsIdentity) user.Identity).IsAuthenticated;

            //        var reservationId = context.GetArgument<int?>("id");
            //        if (reservationId.HasValue)
            //        {
            //            if (reservationId.Value <= 0)
            //            {
            //                context.Errors.Add(new ExecutionError("reservationId must be greater than zero!"));
            //                return new List<Reservation>();
            //            }

            //            return reservationRepository.GetQuery().Where(r => r.Id == reservationId.Value);
            //        }

            //        var checkinDate = context.GetArgument<DateTime?>("checkinDate");
            //        if (checkinDate.HasValue)
            //        {
            //            return reservationRepository.GetQuery()
            //                .Where(r => r.CheckinDate.Date == checkinDate.Value.Date);
            //        }

            //        var checkoutDate = context.GetArgument<DateTime?>("checkoutDate");
            //        if (checkoutDate.HasValue)
            //        {
            //            return reservationRepository.GetQuery()
            //                .Where(r => r.CheckoutDate.Date >= checkoutDate.Value.Date);
            //        }

            //        var allowedSmoking = context.GetArgument<bool?>("roomAllowedSmoking");
            //        if (allowedSmoking.HasValue)
            //        {
            //            return reservationRepository.GetQuery()
            //                .Where(r => r.Room.AllowedSmoking == allowedSmoking.Value);
            //        }

            //        var roomStatus = context.GetArgument<RoomStatus?>("roomStatus");
            //        if (roomStatus.HasValue)
            //        {
            //            return reservationRepository.GetQuery().Where(r => r.Room.Status == roomStatus.Value);
            //        }

            //        return query.ToList();
            //    }
            //);

        }
    }
}