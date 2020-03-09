using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignDelegate
{
    class Trainee
    {
       public  int traineeId;
        public string traineeName;
        public int projectid;

        public Trainee(int traineeId, string traineeName, int projectid)
        {
            this.traineeId = traineeId;
            this.traineeName = traineeName;
            this.projectid = projectid;
        }
        public override string ToString()
        {
            return "TraineeName:"+this.traineeName + " \n" + "TraineeId:"+this.traineeId + "\n " +"ProjectId:"+this.projectid + "";
        }
        public override bool Equals(object obj)
        {
            Trainee temp = (Trainee)obj;
            if (this.projectid == temp.projectid)
                return true;
            else
                return false;
        }
    } 
}

