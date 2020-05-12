using System;

namespace 会員クラス
{
    class Member
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DataTime Birthday { get; set; }
        public string Address { get; set; }
        public string Tel { set; get; }

        public virtual void ShowMemberData()
        {
            Console.WriteLine("$会員番号: {this.ID}");
            Console.WriteLine("$氏　　名: {this.Name}");
            Console.WriteLine("$生年月日: {this.Birthday.ToShortDateString()}");
            Console.WriteLine("$住　　所: {this.Address}");
            Console.WriteLine("$電話番号: {this.Tel}");
        }
        static void Main(string[] args)
        {
            DVDMember dvdMember = new DVDMember();
            FitnessMember fitnessMember = new FitnessMember();


            dvdMember.ID = "D00001";
            dvdMember.Name = "HIRO";
            dvdMember.Birthday = new DateTime(1972, 6, 19);
            dvdMember.Address = "宮城県仙台市";
            dvdMember.Tel = "090-xxxx-xxxx";
            dvdMember.LastDate = new LastTime(2016, 4, 1);

            //派生クラスの ShowMemberData()が呼び出される
            dvdMember.ShowMemberData();

            Console.WriteLine("-------------------------------");

            fitnessMember.ID = "F00001";
            fitnessMember.Name = "Micro";
            fitnessMember.BirthDay = new DateTime(1970, 4, 1);
            fitnessMember.Address = "東京都中央区";
            fitnessMember.Tel = "080-xxxx-xxxx";
            fitnessMember.Weight = 65.3;
            fitnessMember.Height = 175.2;
            fitnessMember.ShowMemberData();


        }
        //クラス名称
        private const string CLASS_NAME = "Member";

        //入会日
        protected DateTime JoinDate { get; set; }
    }

    class DVDMember : Member
    {
        /// <sammary>
        /// 最終レンタル日
        /// </sammary>

        public DateTime LastDate { get; set; }

        //基本クラス名を表示する
        public void ShowBaseClass()
        {
            //基本クラスで定義された CLASS_NAME は private なので使用できない
            Console.WriteLine($"基本クラスは{CLASS_NAME}です。");
        }

        //会員登録日を表示する
        public void ShowJoinDate()
        {
            string strJoinDate = JoinDate.ToShortDateString();
            Console.WriteLine($"会員登録日は{strJoinDate}です。");
        }

        public override void ShowMemberData()
        {
            //基本クラスの ShowMemberData 呼び出し
            base.ShowMemberData();

            Console.WriteLine($"最終レンタル日: {this.LastDate.ToShortDateString()}");
        }

    }

    class FitnessMember : Member
    {
        public double Weight { get; set; }

        public double Height { get; set; }
    }
}
