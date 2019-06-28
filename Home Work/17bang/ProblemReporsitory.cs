using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork._17bang
{
    class ProblemReporsitory:IReporsitory
    {
        public static IList<Problem> Reporsitory=new List<Problem>();

        public void GetBy(User  author)
        {
            var result = from x in Reporsitory
                         where x.Author.Name.ToLower().Contains(author.Name)
                         select x;
            foreach (var item in result)
            {
                Console.WriteLine(item.Tile);
            }
            
        }

        public IList<Problem> ByReward(int reward)//通过棒棒币查找求助！
        {
            List<Problem> NewProblems=new List<Problem>();
            
            var result = from x in Reporsitory
                         where x.Reward > 5
                         select x;
            foreach (var item in result)
            {
                NewProblems.Add(item);
            }
            return NewProblems;
        }
    }
}
