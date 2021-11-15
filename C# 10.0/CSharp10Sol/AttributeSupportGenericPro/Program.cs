//in c sharp 10 you can use attribute on generic way by set preview mode on project setting 
//<LangVersion>preview</LangVersion>

internal class NickAttribute<T> : Attribute 
{
    public T Name { get; set; }
}