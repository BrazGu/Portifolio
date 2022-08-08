namespace Resolvido2_StringBuilder.Entities
{
    class Comment
    {
        //========ATRIBUTO===============
        public string Text { get; set; }
        //===============================



        //============CONSTRUTORES============
        public Comment()
        {//construtor padrão

        }
        public Comment(string text)
        {//construtor com atributo
            Text = text;
        }
        //====================================
    }
}
