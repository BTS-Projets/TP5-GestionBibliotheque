using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp3_Heritage
{
    public class Journal : Document
    {
        private Date dateParution;

        public Date DateParution
        {
            get { return dateParution; }
            set { dateParution = value; }
        }
        public override string ToString()
        {
            return "\n" + base.ToString() + "Date :" + this.DateParution + "\n";
        }
        /// <summary>
        /// constructeur paramétré
        /// </summary>
        /// <param name="titre">titre du journal</param>
        /// <param name="date">date du journal</param>
        public Journal(string titre, DateTime date) : base(titre)
        {
            this.DateParution = new Date(date);
        }

        public override string Type()
        {
            return "Journal";
        }
    }
}
