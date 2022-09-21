# X Operations Mod Editor

X Operations Mod Editor는 일본의 TEAM-METEI가 개발한 인디 FPS 게임 X Operations의 게임 데이터를 수정할 수 있는 프로그램입니다.

일본에서 만들어진 X Operations Mod Supporter가 존재하지만, 한국 환경의 PC에서 실행할 경우 글자가 깨져 일명 '뷁어'로 나타납니다. 한국에서 만들어진 프로그램도 있지만, 더 이상의 업데이트가 없어 새롭게 만들게 되었습니다.

# 상세

## 지원 버전
|싱글|멀티|
|:----------:|:----------:|
|XOPS093 (Not Supported)|XOPSOLT16 (Not Supported)|
|XOPS096|XOPSOLT17 (Not Supported)|
|XOPS096T|XOPSOLT18|
|XOPS097T|XOPSOLT18F|
|XOPS097FT|XOPSOLT18F2|
|XOPS0975T|XOPSOLT19|
||XOPSOLT19F|
||XOPSOLT19F2|

수정을 지원하는 버전은 위 표와 같습니다.<br><br>


## 프로그램 특징
Light Theme | Dark Theme
:----------:|:----------:
![image](https://user-images.githubusercontent.com/36888398/191532070-27757dde-c50c-4734-b41c-98fa122bae16.png)|![image](https://user-images.githubusercontent.com/36888398/191532074-a3d67537-fb3f-4f7e-ab08-6d3c8cae1b3e.png)

라이트 테마와 다크 테마 기능을 제공하며, 프로그램의 설정 값을 따로 보관하지 않기 때문에 프로그램 실행할 때마다 별도로 설정해주셔야 합니다.<br><br>

Process Detect|
:----------:|
![image](https://user-images.githubusercontent.com/36888398/191532660-12d8edee-2fdd-4347-928c-d133dd92284c.png)

실행 중인 프로세스를 캐치 후 메모리에 접근해 게임의 데이터를 수정할 수 있습니다. 실시간으로 반영되는 모습을 볼 수 있습니다.<br><br>

D&D|
:----------:|
![image](https://user-images.githubusercontent.com/36888398/191533030-163b7d04-d1e5-4d3f-8630-dabca069bbba.png)

엑스오퍼레이션의 실행 파일을 프로그램에 D&D(드래그 앤 드롭)하여 데이터를 불러올 수 있습니다.<br><br>

Weapon | Character | SmallObject
:----------:|:----------:|:----------:
![image](https://user-images.githubusercontent.com/36888398/191533276-b9eeb7e6-d576-4937-ad8f-919d5988c76c.png)|![image](https://user-images.githubusercontent.com/36888398/191533286-5e79fd17-0d63-491f-aa7f-2c062eb402a1.png)|![image](https://user-images.githubusercontent.com/36888398/191533292-5c2be1ef-9f30-47b6-a346-8469c9c2a760.png)

무기와 캐릭터, 소품의 데이터를 수정할 수 있습니다. 무기 데이터의 경우 일부 설정 값 옆에 단위를 나타내는 텍스트 박스가 존재합니다.

# 개발 정보
* C# .Netframework 4.8

# 사용된 라이브러리
* [PeHeaderReader](https://gist.github.com/augustoproiete/b51f29f74f5f5b2c59c39e47a8afc3a3)

# 다운로드
* [다운로드](https://github.com/Ssims-kr/XME/releases/tag/Download)

# 여담
* 실행 파일의 버전 체크를 AddressOfEntryPoint를 기준으로하고 있습니다. 우연하게 동일한 EP를 가지는 프로그램을 열 수도 있습니다...(?)
* 프로세스 메모리에 접근하는 코드가 작성되어 있습니다. X Operations 프로세스 외 다른 프로세스를 선택하여 접근하지 말아주세요.
* 일부 하드 코딩의 노가다를 보실 수 있습니다.
