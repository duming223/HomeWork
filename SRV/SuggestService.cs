using BLL;
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public class SuggestService
    {
        private Suggest _suggest;
        private SuggestReporsitory _suggestReporsitory;
        private UserReporsitory _userReporsitory;

        public SuggestService()
        {
            _suggest = new Suggest();
            _userReporsitory = new UserReporsitory();
            _suggestReporsitory = new SuggestReporsitory();
        }

        public void Publish(string title,string body, UserModel userModel)
        {
            _suggest.Title = title;
            _suggest.Body = body;
            _suggest.Author = _userReporsitory.GetByName(userModel.UserName);
            _suggestReporsitory.Save(_suggest);
        }
    }
}
