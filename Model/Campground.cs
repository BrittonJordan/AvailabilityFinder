using System;

namespace Model
{
    public class Campground
    {
        private readonly string name;
        private int reservableCount;
        private int fcfsCount;
        private int totalSites;

        public string Name { get { return name; } }

        public int TotalSites { get { return totalSites; } }

        public int ReservableCount { get { return reservableCount; } }

        public int FcfsCount { get { return fcfsCount; } }

        public Campground(string _name)
        {
            name = _name;
        }

        public void NewReservable()
        {
            reservableCount++;
            totalSites++;
        }

        public void NewFCFS()
        {
            fcfsCount++;
            totalSites++;
        }
    }
}
