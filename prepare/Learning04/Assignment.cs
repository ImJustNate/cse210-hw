using System;
using System.Data;

class Assignment{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;    
    }
    
    public Assignment(){
        _studentName = "Samuel Bennett";
        _topic = "Multiplication";
    }

    public string GetStudentName(){
        return _studentName;
    }
    public string GetSummery(){
        return $"{_studentName} - {_topic}";
    }    

    public string GetSummery(int a){
        return "Samuel Bennett - Multiplication";
    }    
}