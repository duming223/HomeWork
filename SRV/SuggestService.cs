using BLL;
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public class SuggestService
    {
        private Suggest suggest;
        private SuggestReporsitory suggestReporsitory;

        public SuggestService()
        {
            suggest = new Suggest();
            suggestReporsitory = new SuggestReporsitory();
        }

        public void Publish()
        {

        }
    }
}
