using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerLab.Model
{
    public class User
    {
        /// <summary>
        /// 用STJ設定忽略 
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public Guid ID { get; set; } = Guid.NewGuid();
        
        /// <summary>
        /// 用戶名稱
        /// </summary>
        public string Name { get; set; } = "User1";
        
        /// <summary>
        /// 用戶密碼
        /// </summary>
        public string Password { get; set; } = "123456";

        /// <summary>
        /// 安裝Swashbuckle.AspNetCore.Newtonsoft並注入後,可支援忽略屬性
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public DateTimeOffset CreateDT { get; set; }
    }
}
