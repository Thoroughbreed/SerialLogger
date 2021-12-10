
# SerialLogger 
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]

### What is this?
SerialLogger is a very lightweight and simple logging application, built as an extra feature of the
[Intelligent House](https://github.com/jaa2019/H3_Embedded_Intelligent__House) project.

The application is fairly straightforward and takes 5 (five) arguments in total:
| Argument name | Formatting | Description |
 |-|-|-|
| | (Default value) | |
 fileName | `eventlog.txt`| Filename of your log file. Any type is valid
 COM | `COM3` | The serial port on your computer connected to the device
 BAUD | `115200` | The speed of which your device is communicating
 PARITY | `0` | 0-4 (None, Odd, Even, Mark, Space)
 DATABIT | `8` | How many databits you're receiving
 STOPBIT | `1` | 0-3 (None, One, Two, OnePointFive)

If you launch the application without any arguments, it will fallback to default values. 
However, if you want to launch it with arguments the following is valid:
`SerialLog.exe eventlog.txt COM3 115200 0 8 1`
<p align="right">(<a href="#top">back to top</a>)</p>


### License
* Software: GPLv3
<p align="right">(<a href="#top">back to top</a>)</p>


### Contact

Jan Andreasen - [@andreasen_jan](https://twitter.com/andreasen_jan) - jan@tved.it

Project Link: [https://github.com/jaa2019/SerialLogger](https://github.com/jaa2019/SerialLogger)
<p align="right">(<a href="#top">back to top</a>)</p>
