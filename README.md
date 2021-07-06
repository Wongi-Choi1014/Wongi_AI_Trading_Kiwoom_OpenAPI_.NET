# Wongi_AI_Trading_Kiwoom_OpenAPI_C#
 한글의 경우 알파벳, 숫자와 달리 적은 데이터의 수, 이에 비해 많은 음절의 수로 인하여 OCR 인식률이 상대적으로 떨어져 발전에 한계가 있었다. 본 논문에서는 Keras CNN, 정수 인코딩을 이용하여 한글 OCR 프로그램을 설계했다. 학습에 필요한 양질의 데이터를 AI Hub 플랫폼에서 제공하였고, Hyper Parameter을 조절하면서 CNN 모델을 설계하였다. 설계 이후 고찰을 통해서, 향후 한글 OCR 기술이 발전하기 위한 방향을 제시하였다.<br>
 ![image](https://user-images.githubusercontent.com/68767122/89760339-2342a880-db27-11ea-95da-196723db9a98.png)<br>
`※ OCR이란 손글씨나 인쇄 글자를 인식하여 텍스트로 변환하는 기술을 의미`
`※ e-mail : dnjsrl3690@naver.com`
## ①서론
### Keras CNN 구조
![image](https://user-images.githubusercontent.com/68767122/89760971-63eef180-db28-11ea-9cac-8e74de83a485.png)<br>
- Convolutional layer : Edge 등의 각 pixel 간 연관되어 있는 특성을 추출하기 위한 filter 기능을 수행한다. 다수의 데이터를 활용한 학습을 통해서 Filter 의 계수를 획득한다. <br>
- Pooling layer : Subsampling 을 통해서 사이즈를 줄임으로써 Parameter 을 감소시켜 over fitting 문제를 해결한다.<br>
- Relu layer : 0보다 작으면 0으로, 크면 그대로 출력하는 활성화 함수가 포함된 Layer<br>
- Softmax layer : 최종적으로 입력받은 이미지를 특정 한글로 확률 값을 예측하는 Layer<br>
