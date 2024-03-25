using System.Text.RegularExpressions;

namespace FieldValidatorAPI;


public delegate bool RequiredValiDel(string fieldVal);
public delegate bool StringLengValiDel(string fieldVal, int min, int max);
public delegate bool DateValiDel(string fieldVal, out DateTime validDate);
public delegate bool PatternMatchDel(string fieldVal, string pattern);
public delegate bool CompareFieldsValiDel(string fieldVal, string fieldValCompare);

public class CommonFieldValidatiorFunctions
{
    private static RequiredValiDel? _requiredValiDel = null;
    private static StringLengValiDel? _stringLengthValiDel = null;
    private static DateValiDel? _dateValiDel = null;
    private static PatternMatchDel? _patternMatchValidel = null;
    private static CompareFieldsValiDel? _compareFieldsValidel = null;

    public static RequiredValiDel RequiredFieldValDel
    {
        get
        {
            _requiredValiDel ??= new RequiredValiDel(RequiredFieldValid);
            return _requiredValiDel;
        }
    }

    public static StringLengValiDel StringLengthFieldValiDel
    {
        get
        {
            _stringLengthValiDel ??= new StringLengValiDel(StringFieldLengthValid);
            return _stringLengthValiDel;
        }
    }

    public static DateValiDel DateFieldValidDel
    {
        get
        {
            _dateValiDel ??= new DateValiDel(DateFieldValid);
            return _dateValiDel;
        }
    }

    public static PatternMatchDel PatternMatchValidDel
    {
        get
        {
            _patternMatchValidel ??= new PatternMatchDel(FieldPatternValid);
            return _patternMatchValidel;
        }
    }

    public static CompareFieldsValiDel FieldsCompareValidDel
    {
        get
        {
            _compareFieldsValidel ??= new CompareFieldsValiDel(FieldComparisonValid);
            return _compareFieldsValidel;
        }
    }

    //------------ Private Methods
    private static bool RequiredFieldValid(string fieldVal)
    {
        if (!string.IsNullOrEmpty(fieldVal))
            return true;
        return false;
    }

    private static bool StringFieldLengthValid(string fieldVal, int min, int max)
    {
        if (fieldVal.Length >= min && fieldVal.Length <= max)
            return true;
        return false;
    }

    private static bool DateFieldValid(string dateTime, out DateTime validDateTime)
    {
        if (DateTime.TryParse(dateTime, out validDateTime))
            return true;
        return false;
    }

    private static bool FieldPatternValid(string fieldVal, string regularExpressionPattern)
    {
        Regex regex = new(regularExpressionPattern);
        if (regex.IsMatch(fieldVal))
            return true;
        return false;
    }

    private static bool FieldComparisonValid(string field1, string field2)
    {
        if (field1.Equals(field2))
            return true;
        return false;
    }
}
