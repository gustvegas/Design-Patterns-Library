using System;

namespace AdapteePattern
{
    public class Intranet
    {

        private IIntranetPhoneList _phoneList;

        public Intranet(IIntranetPhoneList phoneList)
        {
            _phoneList = phoneList;
        }

        public string GetIntranetList()
        {
            return _phoneList.GetPhoneList();
        }
    }
}