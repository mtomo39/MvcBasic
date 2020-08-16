using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcBasic.Models
{
    public class Member
    {
        public int Id { get; set; }

        [DisplayName("氏名")]
        public string Name { get; set; }

        [DisplayName("メールアドレス")]
        public string Email { get; set; }

        [DisplayName("生年月日")]
        public DateTime Birth { get; set; }

        [DisplayName("既婚")]
        public bool Married { get; set; }

        [DisplayName("自己紹介")]
        public string Memo { get; set; }
    }
}