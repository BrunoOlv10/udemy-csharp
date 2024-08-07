using System;
using System.Collections.Generic;
using System.Text;

namespace curso_udemy.recuperar_instituicao_ano
{
    public class GptModel
    {
        public class BodyGPT
        {
            public string model { get; set; }
            public List<Messages> messages { get; set; }
        }

        public class Messages
        {
            public string role { get; set; }
            public string content { get; set; }
        }
    }
}
