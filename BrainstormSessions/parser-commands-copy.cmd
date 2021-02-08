LOGPARSER "SELECT Text FROM C:\Users\Darya_Kotova\Desktop\Logging\BrainstormSessions\bin\Debug\netcoreapp3.0\Logs\Example.log" -i:TEXTLINE -q:Off

LOGPARSER "SELECT COUNT(Text) FROM C:\Users\Darya_Kotova\Desktop\Logging\BrainstormSessions\bin\Debug\netcoreapp3.0\Logs\Example.log WHERE Text LIKE '%%ERROR%%'" -i:TEXTLINE -q:Off

PAUSE