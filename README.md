![Build succeeded][build-shield]
![Test passing][test-shield]
[![Issues][issues-shield]][issues-url]
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![License][license-shield]][license-url]
# SerialLogger

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
`SerialLog.exe eventlog.txt 3 115200 0 8 1`

Before the application starts listening, you can now validate the settings (and change them if needed)
<p align="right">(<a href="#top">back to top</a>)</p>

### Changelog
| Version | Change |
|-|-|
| 0.0.5 | First release, using arguments / fallback to default |
| 0.1.0 | Added simple menu to change values if no or incorrect arguments were given. Added control logic to limit input of databits |
| 0.1.1 | Added a friendly exception message |
<p align="right">(<a href="#top">back to top</a>)</p>

### License
* Software: GPLv3
<p align="right">(<a href="#top">back to top</a>)</p>


### Contact


Jan Andreasen - jan@tved.it

[![Twitter][twitter-shield]][twitter-url]

Project Link: [https://github.com/jaa2019/SerialLogger](https://github.com/jaa2019/SerialLogger)
<p align="right">(<a href="#top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[build-shield]: https://img.shields.io/badge/Build-succeeded-brightgreen.svg
[test-shield]: https://img.shields.io/badge/Tests-passing-brightgreen.svg
[contributors-shield]: https://img.shields.io/github/contributors/jaa2019/SerialLogger.svg?style=badge
[contributors-url]: https://github.com/jaa2019/SerialLogger/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/jaa2019/SerialLogger.svg?style=badge
[forks-url]: https://github.com/jaa2019/SerialLogger/network/members
[issues-shield]: https://img.shields.io/github/issues/jaa2019/SerialLogger.svg?style=badge
[issues-url]: https://github.com/jaa2019/SerialLogger/issues
[license-shield]: https://img.shields.io/github/license/jaa2019/SerialLogger.svg?style=badge
[license-url]: https://github.com/jaa2019/SerialLogger/blob/master/LICENSE
[twitter-shield]: https://img.shields.io/twitter/follow/andreasen_jan?style=social
[twitter-url]: https://twitter.com/andreasen_jan
