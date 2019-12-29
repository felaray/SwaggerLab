using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerLab.Model
{
    public class User
    {
        /// <summary>
        /// 用STJ設定忽略 
        /// </summary>
        //[System.Text.Json.Serialization.JsonIgnore]  // (與Newtonsoft只能擇一)
        [Newtonsoft.Json.JsonIgnore]
        public Guid ID { get; set; } = Guid.NewGuid();


        /// <summary>
        /// 用戶名稱
        /// </summary>
        [Required,StringLength(20)]
        public string Name { get; set; } = "User1";

        /// <summary>
        /// 用戶密碼
        /// </summary>
        [Required, StringLength(20)]
        public string Password { get; set; } = "123456";

        /// <summary>
        /// 用戶手機
        /// </summary>
        [Required, StringLength(20)]
        public string Mobile { get; set; } = "+886912345678";

        
        public DateTimeOffset Birthday { get; set; }

        /// <summary>
        /// 安裝Swashbuckle.AspNetCore.Newtonsoft並注入後,可支援忽略屬性
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public DateTimeOffset CreateDT { get; set; }
    }
}
