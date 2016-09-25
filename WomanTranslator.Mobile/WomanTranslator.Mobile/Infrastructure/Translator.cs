using System.Collections.Generic;

namespace WomanTranslator.Mobile.Infrastructure
{
    public class Translator
    {

        private readonly Dictionary<string, string> _knownWords = new Dictionary<string, string>
        {
            {"no", "Si"},
            { "si","No"},
            { "tal vez","No"},
            {"decide tu","haz lo que yo digo"},
            { "haz lo que quieras","Ni te atrevas"},
            { "no estoy enojada","Por supuesto que estoy enojada imbecil!!"},
            { "estoy gorda?","Dime que estoy flaca."},
            { "Yo lo hago","Tarado te lo he pedido mil veces…no soy tu madre."}
        };

        public string Translate(string original)
        {
            var key = original.ToLower();
            var exist = _knownWords.ContainsKey(key);
            if (!exist)
            {
                return "Ni yo puedo decifrar que significa.";
            }
            return _knownWords[key];
        }
    }
}
