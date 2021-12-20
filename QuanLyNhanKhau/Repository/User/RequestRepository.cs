using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanKhau.Model;
namespace QuanLyNhanKhau.Repository
{
    public enum ResolveType
    {
        UNAPPROVE,
        APPROVED,
        DENY,
        UNDEFINE
    }
    public static class ResolveTypeImp
    {
        public static ResolveType Parser(string s)
        {
            switch (s.Trim())
            {
                case "UNAPPROVED":
                    return ResolveType.UNAPPROVE;
                case "APPROVED":
                    return ResolveType.APPROVED;
                case "DENY":
                    return ResolveType.DENY;
                default: return ResolveType.UNDEFINE;
            }
        }
        public static string ToString(this ResolveType t)
        {
            switch (t)
            {
                case ResolveType.UNAPPROVE:
                    return "UNAPPROVED";
                case ResolveType.APPROVED:
                    return "APPROVED";
                case ResolveType.DENY:
                    return "DENY";
                default:
                    return "";
            }
        }
    }
    public enum RequestType
    {
        TamTru,
        TamVang,
        Undefine
    }
    public static class RequestTypeImp
    {
        public static string ToString(this RequestType t)
        {
            switch (t)
            {
                case RequestType.TamVang:
                    return "TEMPORARY_ABSENCE";
                case RequestType.TamTru:
                    return "TEMPORATE_CITIZEN";
                default:
                    return "";
            }
        }
    }
    public class RequestRepository
    {
        private ModelHelper _modelHeper;
        private QuanLyNhanKhauDBSchemaEntities ctx;
        public RequestRepository()
        {
            ctx = new QuanLyNhanKhauDBSchemaEntities();
            this._modelHeper = ModelHelper.Instance;
        }
        public TemporaryRequest createTamTruRequest(User user, string reason, DateTime expired)
        {
            return createTempRequest(RequestType.TamTru, user, reason, expired);
        }
        public TemporaryRequest createTamVangRequest(User user, string reason, DateTime expired)
        {
            return createTempRequest(RequestType.TamVang, user, reason, expired);
        }
        public TemporaryRequest resolveRequestByReqId(int id, User user, ResolveType approved, string description)
        {
            var req = (from p in ctx.TemporaryRequests
                       where p.RequestId == id
                       select p).FirstOrDefault();
            if (req != null)
            {
                req.Approved = approved.ToString();
                req.UResolveBy = user;
                req.ResolveDescription = description;
            }
            return req;
        }
        private TemporaryRequest createTempRequest(RequestType type, User user, string reason, DateTime expired)
        {
            var newtemporary = new TemporaryRequest();
            newtemporary.RequestType = type.ToString();
            newtemporary.Reason = reason;
            newtemporary.ExpiredDate = expired;
            newtemporary.URequestBy = user;
            newtemporary.Reason = reason;
            newtemporary.CitizenDetail = user.CitizenDetails.FirstOrDefault();
            return ctx.TemporaryRequests.Add(newtemporary);
        }
    }
}
