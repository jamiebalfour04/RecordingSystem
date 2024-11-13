This program is a C#-based recording system that allows users to record messages that an administrator can then access. 

## Roles

### Administrator
The program is precompiled with an administrator username and password. Once the administrator is in the system, they are presented with a list of messages added by other users. On this screen, they will also receive an alert when a new message has been added in real-time. They can then proceed to view the messages individually.

### Reporter
A reporter is a generic user who does not need to provide a password. Instead, the reporter can simply report new messages.

## Genericism
The program is designed to be generic in its implementation, thus allowing the program to be quickly modified to suit different purposes. This is done from the Properties/Resources.resx file. Many things can be changed, such as the string for reporters and subjects based on the context, the application name, and the username and password of the administrators. 

## Performance etc.
The program is written to take advantage of the .NET Framework's performance and uses Windows Forms for the interface. It was also designed to be quick and easy to produce hence why I stuck with Windows Forms.
