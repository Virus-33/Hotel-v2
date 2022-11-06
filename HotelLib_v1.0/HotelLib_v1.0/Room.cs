namespace HotelLib_v1._0
{
    public class Room
    {
        public int Num
        {
            get;
            private set;
        }
        public string type
        {
            get;
            private set;
        }
        public CurStat status
        {
            get;
            private set;
        }
        public int price
        {
            get; private set ;
        }

        public Room(int _num, string _t, int _p, CurStat stat)
        {
            Num = _num;
            price = _p;
            type = _t;
            status = stat;
        }

        public void Unbook()
        {
            this.status = CurStat.available;
        }
        
        public void Book()
        {
            this.status = CurStat.booked;
        }
    }
}
