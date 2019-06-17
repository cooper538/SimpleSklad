using Core.Flash;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace SimpleSklad.Services
{
    public class FlasherExtended : Flasher, IFlasherExtended
    {
        public FlasherExtended(ITempDataDictionaryFactory factory, IHttpContextAccessor contextAccessor) : base(factory, contextAccessor)
        {
        }

        public void FlashSuccess(string msg)
        {
            Flash("success", msg);
        }

        public void FlashInfo(string msg)
        {
            Flash("info", msg);
        }

        public void FlashWarning(string msg)
        {
            Flash("warning", msg);
        }

        public void FlashDanger(string msg)
        {
            Flash("danger", msg);
        }
    }

    public interface IFlasherExtended : IFlasher
    {
        void FlashSuccess(string msg);
        void FlashInfo(string msg);
        void FlashWarning(string msg);
        void FlashDanger(string msg);
    }
}
