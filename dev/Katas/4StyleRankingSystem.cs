using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.Katas
{
    public class User
    {
        private int _rank;
        public int rank { 
            get { return _rank; } 
            private set {
                _rank = value;

                if (_rank == 8) progress = 0;
            } 
        }
        private int _progress;
        public int progress {
            get { return _progress; }
            private set {
                _progress = value;

                if (_progress >= 100)
                {
                    if (rank == -1)
                    {
                        rank = 1;
                    } else
                    {
                        rank++;
                    }
                    this.progress = _progress - 100;
                }
                if (rank == 8) _progress = 0;
            } }
        public User()
        {
            this.rank = -8;
            this.progress = 0;
        }

        public void incProgress(int rankActivity)
        {
            if (rankActivity == 0 || rankActivity < -8 || rankActivity > 8)
            {
                throw new System.ArgumentException();
            }
            int difRank = rankActivity - rank;
            
            if (rankActivity > 0 && rank < 0)
            {
                difRank--;
            }

            //Any activities completed that are ranking 2 levels or more lower than the user's ranking will be ignored
            if (difRank < -2) return;

            // Completing an activity that is ranked the same as that of the user's will be worth 3 points
            if (difRank == 0)
            {
                progress += 3;
            } 
            else
            {
                // Completing an activity that is ranked one ranking lower than the user's will be worth 1 point
                if (difRank < 0)
                {
                    progress += 1;
                }
                else
                // Completing an activity ranked higher than the current user's rank will accelerate the rank progression. The greater the difference between rankings the more the progression will be increased. The formula is 10 * d * d where d equals the difference in ranking between the activity and the user.
                {
                    progress += (10 * difRank * difRank);
                }
            }
            
            

        }

    }
}
