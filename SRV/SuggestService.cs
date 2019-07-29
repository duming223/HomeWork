using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static SRV.UserService;

namespace SRV
{
    public class SuggestService : BaseService
    {
        private Suggest _suggest;
        private IList<Suggest> _suggests;
        private SuggestReporsitory _suggestReporsitory;

        public SuggestService(SuggestReporsitory suggestReporsitory, IHttpContextAccessor httpContextAccessor,
            UserReporsitory userReporsitory)
            : base(userReporsitory, httpContextAccessor)
        {
            _suggestReporsitory = suggestReporsitory;
        }

        public Suggest Publish(DTOSuggestModel dTOSuggestModel)
        {
            Suggest suggest = Mapper.Map<DTOSuggestModel, Suggest>(dTOSuggestModel);
            suggest.Publish();
            return _suggestReporsitory.Save(suggest);

            //_suggest = new Suggest();
            //_suggest.Title = title;
            //_suggest.Body = body;
            //_suggest.Author = _userReporsitory.GetByName(userModel.UserName);
            //_suggestReporsitory.Save(_suggest);
            //return _suggest;
        }

        public IList<DTOSuggestModel> GetList(int pageIndex, int pageSize)
        {
            _suggests = _suggestReporsitory.GetList(pageIndex, pageSize);
            return Mapper.Map<IList<Suggest>, IList<DTOSuggestModel>>(_suggests);
        }

        public IList<DTOSuggestModel> GetListByAuthorId(int Authorid)
        {
            _suggests= _suggestReporsitory.GetListByAuthorId(Authorid);
            return Mapper.Map<IList<Suggest>, IList<DTOSuggestModel>>(_suggests);
        }

        public DTOSuggestModel GetBy(int suggestid)
        {
            _suggest = _suggestReporsitory.GetBy(suggestid);

            return Mapper.Map<Suggest, DTOSuggestModel>(_suggest);

            //DTOSuggestModel dto = new DTOSuggestModel
            //{
            //    Id = _suggest.Id,
            //    Author = _suggest.Author,
            //    Title = _suggest.Title,
            //    Body = _suggest.Body
            //};
            //return dto;
        }
    }

    public class DTOSuggestModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "必须填写！")]
        [MaxLength(15, ErrorMessage = "标题不能超过15字")]
        public string Title { get; set; }
        [Required(ErrorMessage = "必须填写！")]
        [MaxLength(200, ErrorMessage = "内容不能超过200字")]
        public string Body { get; set; }
        public User Author { get; set; }
    }
}
