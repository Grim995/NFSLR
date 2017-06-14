using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NFSLR.Core
{
    public class Options
    {
        enum State
        {
            None,
            Name,
            Dots,
            Val,
            Str,
            End
        }

        private void Set(string name, string val)
        {
            Type t = this.GetType();
            PropertyInfo i = t.GetProperty(name);
            foreach(object attr in i.GetCustomAttributes())
            {
                if(attr is PropertyAttribute)
                {
                    Type decl = i.PropertyType;
                    if(decl == typeof(bool))
                    {
                        i.SetValue(this, bool.Parse(val));
                    }
                    if(decl == typeof(int))
                    {
                        i.SetValue(this, int.Parse(val));
                    }
                    if(decl == typeof(string))
                    {
                        i.SetValue(this, val);
                    }
                    if(decl == typeof(float))
                    {
                        i.SetValue(this, float.Parse(val));
                    }
                    if(decl == typeof(double))
                    {
                        i.SetValue(this, double.Parse(val));
                    }

                }
            }

        }

        private void ParseString(string str)
        {
            State st = State.None;
            string tok = "";
            string name = null;
            string val = null;
            int i = 0;
            while (i < str.Length)
            {
                if (str[i] == '#')
                    break;
                switch (st)
                {

                    case State.None:
                        if (str[i] == ' ')
                        {
                            if (tok == "")
                            {
                                i++;
                                break;
                            }
                            name = tok;
                            tok = "";
                            st = State.Dots;
                            i++;
                            break;
                        }
                        if (str[i] == ':')
                        {
                            name = tok;
                            tok = "";
                            st = State.Val;
                            i++;
                            break;
                        }
                        tok += str[i];
                        i++;
                        break;
                    case State.Dots:
                        switch (str[i])
                        {
                            case ' ':
                                i++;
                                break;
                            case ':':
                                i++;
                                st = State.Val;
                                break;
                            default:
                                throw new Exception();
                        };
                        break;
                    case State.Val:
                        switch (str[i])
                        {
                            case ' ':
                                if (tok == "")
                                {
                                    i++;
                                    break;
                                }
                                st = State.End;
                                val = tok;
                                tok = "";
                                i++;
                                break;
                            case '"':
                                if (tok != "")
                                    throw new Exception();
                                st = State.Str;
                                i++;
                                break;
                            default:
                                tok += str[i];
                                i++;
                                break;
                        };
                        break;
                    case State.Str:
                        if (str[i] == '"')
                        {
                            st = State.End;
                            val = tok;
                            tok = "";
                            i++;
                            break;
                        }
                        tok += str[i];
                        i++;
                        break;
                    case State.End:
                        if (!char.IsWhiteSpace(str[i]))
                            throw new Exception();
                        i++;
                        break;
                }
            
            }
            if (tok != "")
                val = tok;
            if (name == null || val == null)
                throw new Exception();
            Set(name, val);

        }

        public void Parse(string[] text)
        {
            foreach (string t in text)
                ParseString(t);
        }

        public void Save(string filepath)
        {
            StreamWriter sw = new StreamWriter(filepath);
            Type t = this.GetType();
            foreach(PropertyInfo inf in t.GetProperties())
            {
                foreach(object attr in inf.GetCustomAttributes())
                {
                    if(attr is PropertyAttribute)
                    {
                        bool isString = inf.PropertyType == typeof(string);
                        string fmt = isString ? "{0}: \"{1}\"" : "{0}: {1}";
                        sw.WriteLine(fmt, inf.Name, inf.GetValue(this).ToString());
                    }
                }
            }
            sw.Close();
        }
    }
}
