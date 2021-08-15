# Wongi_AI_Trading_Kiwoom_OpenAPI_C#
본 프로그램은 키움(Kiwoom) OpenAPI를 활용하여 AI 및 알고리즘 매매를 수행한다. AI에 강력한 Python기반으로 제작하려 하였으나, API사용이 용이하고 GUI 기반에서 편리한 코드 작성이 가능한 C#을 최종 선택하였다. <br>

`※ e-mail : dnjsrl3690@naver.com`
## ①서론
### 키움 OpenAPI
![image](https://user-images.githubusercontent.com/68767122/129469565-4970850c-760f-4dfc-b86f-13118c92b6c3.png)<br>
키움 증권에서는 직접 프로그램 투자를 할 수 있도록 OpenAPI+ 서비스를 제공하고 있다.<br>
![image](https://user-images.githubusercontent.com/68767122/129469597-5af0715d-b8a3-4ae4-af08-1f75b0b76d0a.png)<br>
![image](https://user-images.githubusercontent.com/68767122/129469603-d49cc407-581b-4213-a99a-76fe44f9780c.png)<br>
https://www.kiwoom.com/h/customer/download/VOpenApiInfoView  (출처)<br>
위 사이트에서 OpenAPI 신청 및 다운로드가 가능하다. <br>
추가로 키움증권에서 제공하는 함수를 직관적으로 확인할 수 있도록 KOA Studio라는 프로그램을 제공한다.<br>
![image](https://user-images.githubusercontent.com/68767122/129469902-eae88532-ede8-4a53-b6fb-1f9a84eadd4d.png)<br>
![image](https://user-images.githubusercontent.com/68767122/129470472-b6e5997d-8060-456f-be57-a6f8fe72adb3.png)<br>
KOA Studio 확인 시 OpenAPI에서는 서버를 통한 데이터 요청과 수신(이벤트 호출)을 통해 동작함을 확인할 수 있다.<br>
### C# (개발 언어) 및 샘플 코드
개발 언어는 C#으로 선정하였다. Python에서 AI연동 및 다양한 라이브러리 사용이 가능하지만 C#을 최종적으로 선택한 이유는 다음과 같다.<br>
- Pyqt 대비 Window Form의 직관성 / 개발 편의성
- C# 또한 다양한 라이브러리 존재
- C#의 우수한 메모리 관리 기능 (Garbage Collector)
- Compiler 언어 특성으로 한번 컴파일 이후로는 빠른 성능
<br><br>
C#으로 개발하기 앞서 예제 코드를 보면서 어떻게 프로그램을 작성해야 할 지 생각하였다.<br>
![image](https://user-images.githubusercontent.com/68767122/129471113-483b48ad-38c8-4cb4-afff-75cd73c1e1ed.png)<br>
![image](https://user-images.githubusercontent.com/68767122/129471116-c14e3493-93e3-4817-b389-5d890098e45f.png)<br>

다음과 같은 구조로 되어있다. <br>
- Window Form에서 버튼 / Label 등 GUI 영역을 만든 후 로그인 / 조회 / 주문 등의 요청를 수행한다.
- 별도 구현한 이벤트 함수를 통해 데이터 수신 시 함수 작동
<br><br>
OpenAPI 라이브러리를 Form에서 가져왔는데, 도구상자 - 마우스 우클릭 - 항목선택 클릭 시 COM 구성요소에서 키움 OpenAPI를 확인할 수 있다.<br>
![image](https://user-images.githubusercontent.com/68767122/129471121-6a50b7c7-3896-4cc6-b2eb-9e602b2a96e5.png)<br>
## ②프로그램 설계
![image](https://user-images.githubusercontent.com/68767122/129473789-597fdfcc-b690-4b3e-8d11-6f83e568a128.png)<br>
프로그램 설계 방향은 다음과 같았다.
- 예제 코드 기반으로 코드 작성 (개발 기간 단축)
- 차트 Plot 기능 추가
- 원하는 알고리즘을 선택하고 실행할 시 자동매매가 동작하도록 설정
- 예수금에서 사용할 금액을 %로 지정
### 로그 출력
![image](https://user-images.githubusercontent.com/68767122/129473647-9340e003-f8fe-41e7-bf90-e9c96253f91b.png)<br>
Log Interface를 만들어 Form에서 상속하도록 설정<br>
 -> 순환참조를 막고 외부 클래스(알고리즘 등)에서 Form에 존재하는 Log에 출력할 수 있도록 설정<br>
### 차트 출력
![image](https://user-images.githubusercontent.com/68767122/129473834-c2e42995-8670-4b94-9a2b-2de36b0a9a24.png)<br>
"주식일봉차트조회"데이터 전송 시 차트 출력 변수로 On으로 설정하면 수신 이벤트 발생 시 차트 출력하도록 설정<br>
### 알고리즘
현재 설계 中
