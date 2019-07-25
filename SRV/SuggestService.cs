using BLL;
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using static SRV.UserService;

namespace SRV
{
    public class SuggestService
    {
        private Suggest _suggest;
        private SuggestReporsitory _suggestReporsitory;
        private UserReporsitory _userReporsitory;

        public SuggestService(SuggestReporsitory suggestReporsitory,UserReporsitory userReporsitory)
        {
            _suggestReporsitory = suggestReporsitory;
            _userReporsitory =userReporsitory;

        }

        public void Publish(string title,string body, DTOUserModel userModel)
        {
            _suggest = new Suggest();
            _suggest.Title = title;
            _suggest.Body = body;
            _suggest.Author = _userReporsitory.GetByName(userModel.UserName);
            _suggestReporsitory.Save(_suggest);
        }
    }

    public class DTOSuggestModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
    }
}
