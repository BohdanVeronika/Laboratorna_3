using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Labwork3
{
    public partial class Task1Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var positions = new SortedList<string, int>();
            var workers = new SortedList<int, string>();

            foreach (var worker in DataProvide.Workers)
            {
                workers.Add(worker.IdOfWorker, worker.Position);

                if (positions.Count(p => p.Key == worker.Position) == 0)
                {
                    positions.Add(worker.Position, 0);
                }
            }

            foreach (var premium in DataProvide.Premiums)
            {
                if (premium.Date.Year == DateTime.Now.Year)
                {
                    string temp = workers[premium.Id];
                    positions[temp] += 1;
                }
            }

            var resultList = new List<string>();
            foreach (var item in positions)
            {
                if (item.Value == 0) resultList.Add(item.Key);
            }

            if (resultList.Count > 0)
            {
                ResultGridView.DataSource = resultList;
                ResultGridView.DataBind();
            }
            else
            {
                string[] text = { "Not found!" };
                ResultGridView.DataSource = text;
                ResultGridView.DataBind();
            }
        }
        
        protected void TaskButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}