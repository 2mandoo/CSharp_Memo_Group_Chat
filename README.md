# CSharp_Memo_Group_Chat
![CSharp](https://camo.githubusercontent.com/16113eb52d90f59b94c5c47d0a7937d2765f9a2a21853e76a6a82234397b6e33/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f4353686172702d3643343746463f7374796c653d666c6174266c6f676f3d43706c7573706c7573266c6f676f436f6c6f723d7768697465)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=flat&logo=.net&logoColor=white)
<code>WinForm</code>

C#과 WinForms를 사용하여 제작된 간단한 단체 채팅방 애플리케이션입니다.

메모장과 같은 직관적인 인터페이스를 통해 실시간으로 여러 사용자와 텍스트 채팅을 할 수 있습니다.


#### 주요 기능
- 실시간 채팅: 여러 사용자 간 텍스트 기반의 실시간 대화 지원.
- 사용자 닉네임 표시: 서버와 클라이언트에서 채팅에 참여하는 모든 사용자의 닉네임이 표시됩니다.
- 대화 내용 초기화: 채팅창에서 cls 명령어를 입력하면 대화 내용을 간단히 초기화할 수 있습니다.
- 간편한 인터페이스: 메모장과 유사한 깔끔하고 직관적인 디자인.
- 경량 애플리케이션: 빠르고 가벼운 실행 환경 제공.


#### 개인 프로젝트 (2024.11.06 ~ 2024.11.07)


#### UI
<code>[Server Start]</code> 버튼을 클릭하여 서버를 시작합니다.

![server](https://github.com/user-attachments/assets/3e00c29f-da30-41f7-a59f-5d7fba567c18)

클라이언트 코드의 IP를 서버의 IP로 맞춘 후 클라이언트를 실행합니다.

닉네임 작성후 <code>[chat]</code> 버튼을 클릭하면 서버와 연결됩니다.

서버와의 연결을 종료하고 싶다면 <code>[disconnect]</code> 버튼을 클릭합니다.

cls 명령어를 입력하거나 <code>[clear]</code> 버튼을 클릭하면 대화 내용이 초기화됩니다.

![client](https://github.com/user-attachments/assets/ea22f0a2-f1b7-4618-b088-9097efd7c3d2)


#### 추후 개선할 사항
- client disconnect 시 에러 처리
- sever가 client 보다 먼저 종료될 시 에러 처리
- 채팅방 여러개 만들기


