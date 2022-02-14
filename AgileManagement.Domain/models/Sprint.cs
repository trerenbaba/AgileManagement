using AgileManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Domain
{
    public class Sprint : Entity
    {
        public string SprintName { get; set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public Sprint(DateTime startDate, DateTime endDate)
        {
            Id = Guid.NewGuid().ToString();
        }

        private void SetSprintTime(DateTime startDate, DateTime endDate)
        {
            if (startDate == null || EndDate == null)
            {
                throw new Exception("start date ve enddate boş geçilemez");
            }
            StartDate = startDate;
            EndDate = endDate;
        }

        public void SetSprintName(int sprintCount)
        {

            this.SprintName = "Sprint" + sprintCount;
        }

        


    }
}
