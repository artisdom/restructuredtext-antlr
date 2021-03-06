﻿namespace Lextm.ReStructuredText
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITextArea
    {
        bool IsIndented { get; }
        Content Content { get; }
        int Indentation { get; set; }
        bool IsQuoted { get; }
        ElementType TypeCode { get; }
        Scope Scope { get; }
    }
}