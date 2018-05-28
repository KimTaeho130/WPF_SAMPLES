using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVV_SAMPLE01
{
    public class ScoreCollection : ObservableCollection<Score>
    {
        public ScoreCollection()
        {
            Add(new Score() { SUBJECT = "Englsh", SCORE = 95 });
            Add(new Score() { SUBJECT = "Mathmatics", SCORE = 55 });
            Add(new Score() { SUBJECT = "History", SCORE = 65 });
        }
    }

    public class Score
    {
        public string SUBJECT { get; set; }
        public int SCORE { get; set; }
    }


}
