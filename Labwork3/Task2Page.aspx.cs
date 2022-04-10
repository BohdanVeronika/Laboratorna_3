using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Labwork3
{
    public partial class Task2Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var positions = new SortedList<string, int>();
            var workers = new SortedList<int, string>();

            foreach (var worker in DataProvide.Workers)
            {
                if (positions.Count(p => p.Key == worker.Position) == 0)
                {
                    positions.Add(worker.Position, 0);
                }

                if (worker.Sex.Equals("Male"))
                {
                    workers.Add(worker.IdOfWorker, worker.Position);
                    positions[worker.Position] += worker.Salary;
                }
            }

            foreach (var premium in DataProvide.Premiums)
            {
                if (workers.Keys.Contains(premium.Id))
                {
                    string tmp = workers[premium.Id];
                    positions[tmp] += premium.SumOfPremium;
                }
            }

            var resultList = new SortedList<string, int>();

            foreach (var item in positions)
            {
                int avrgSalary = 0;
                if (workers.Count(w => w.Value == item.Key) != 0)
                    avrgSalary = item.Value / workers.Count(w => w.Value == item.Key);
                
                resultList.Add(item.Key, avrgSalary);
            }

            ResultGridView.DataSource = resultList;
            ResultGridView.DataBind();
        }
    }
}