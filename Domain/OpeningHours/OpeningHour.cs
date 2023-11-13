using Ardalis.GuardClauses;
using Oogarts.Domain.Businesses;
using Oogarts.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Domain.OpeningHours
{
    public class OpeningHour : Entity
    {

        private int businessid = default!;
        
        public int BusinessId
        {
            get => businessid;
            set => businessid = Guard.Against.Null(value, nameof(businessid));
        }

        private DateTime openingTime = default!;

        public DateTime OpeningTime
        {
            get => openingTime;
            set => openingTime = Guard.Against.Null(value, nameof(OpeningTime));
        }


        private DateTime closingTime = default!;

        public DateTime ClosingTime
        {
            get => closingTime;
            set => closingTime = Guard.Against.Null(value, nameof(ClosingTime));
        }

        private int dayOfWeek = default!;

        public int DayOfWeek
        {

            get => dayOfWeek;
            set => dayOfWeek = Guard.Against.Null(value, nameof(DayOfWeek));
        }
        public Business Business { get; set; }
        private OpeningHour()
        {
            // Parameterless constructor
        }
        public OpeningHour(int businessid, DateTime openingTime, DateTime closingTime, int dayOfWeek) {
            BusinessId = businessid;
            OpeningTime = openingTime;
            ClosingTime = closingTime;
            DayOfWeek = dayOfWeek;
        }
    }
}
