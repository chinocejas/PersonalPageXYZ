using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalPage.Entities
{
    public class PersonalInfoDTO
    {
        public PersonalInfoDTO(string name, string nickName)
        {
            Name = name;
            NickName = nickName;
        }

        public string Name { get; set; }

        public string  NickName { get; set; }
    }
}
