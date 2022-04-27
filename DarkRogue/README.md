# Map
-진행 상황
> 4/11~4/12
![진행](https://user-images.githubusercontent.com/99639267/163134243-d0c8040a-cf29-481d-9056-0c1234e35812.png)
- 바닥만 2/9 배치
- 풀 애니메이션 2개
- 부수는 벽 이미지( 부숴지는 것은 구현 x )
> 4/13
![1번맵틀](https://user-images.githubusercontent.com/99639267/163133402-5c3131d1-7a01-42eb-947d-7d8a6bc03d6e.png)
- 1번 맵 형태만 박스로 배치
> 4/14
![진행상황](https://user-images.githubusercontent.com/99639267/163350208-a4c1466c-2514-4a5e-aa3c-5a2f846b1dd2.png)
- 바닥만 1층, 2층가는 길 완성
> 4/18
![door3](https://user-images.githubusercontent.com/99639267/163789616-21688163-bd53-422c-a3ce-399719852a9e.png)
- 문 애니메이션

> 4/20
![가로](https://user-images.githubusercontent.com/99639267/164375689-89d0aaa6-e746-4589-9580-761bdcead7fc.png)
![부품](https://user-images.githubusercontent.com/99639267/164375699-32570949-fd38-4dd9-8206-fca501e34c44.png)
- 맵 축소, 마을 sprite 준비




> 4/21
![Vill](https://user-images.githubusercontent.com/99639267/164379644-273b0613-fcc2-4469-af69-3066ba7ee17e.png)
- 마을맵 Layers(Ground)에서 작업, Sprite 그대로 사용
- BackGround, Ground, FrontGround 오브젝트는 z축 위치를 바꾸기 위해 나눔. Sorting Layers에서 앞 뒤 구분
![마을맵](https://user-images.githubusercontent.com/99639267/164385507-d0344570-33a9-4899-b991-1c8124899f03.png)
- Grass 3~5(프리팹), 박스콜라이더로 Camera 안쪽 벽, 나머지 배경배치

> 4/22
![Boss](https://user-images.githubusercontent.com/99639267/164674514-7d2e04a1-ab50-445a-911b-03b1565d80f0.png)

- 보스맵 Crowd 애니메이션, BackGround, Ground, FrontGround1, FrontGround2는 장식. Sorting Layers에서 앞 뒤 구분

> 4/25 ~ 26
![Portal](https://user-images.githubusercontent.com/99639267/165413423-07df01f2-9b9e-4047-b249-6f9a82159d7d.png)
- 포탈구현 프리팹 : Portal1~3(마을, 튜토, 보스), Canvas1(UI1)2(UI2,3), PortalController, Sprite+Animation
> 작동방식
- Build Setting에서 Scene 추가
- Portal 콜라이더 트리거가 tag Player와 만날 시 캔버스 활성화 -> 떨어지면 비활성화 -> 포탈UI가 활성화 되었고 키보드 윗키 누를 시 이동
- Portal에 PortalController 컴포넌트 추가하고 PortalUI와 Portal의 Prefab을 적용(튜토와 보스는 Portal1, Canvas1(UI1), 마을은 Portal2,3과 Canvas2(UI2,3))

- 완성 후 할 것
- 석상, 튜토리얼맵 장식추가
- 튜토리얼맵 Layers 정리 > 기능 추가..( 시네마틱 카메라 )

- 진행 형태
튜토리얼맵은 프리팹으로 만들어서 재배치 후 SortingLayer와 OrderLayer를 사용 -> 맵 완성 후 정리필요
마을맵과 보스맵은 Sprite 그대로 붙여넣고 SortingLayer와 게임오브젝트의 z축을 이용해 배치

- 참고
Heirachy에서 1Floor -> 맵 프리팹
MapScene 설명
- reBack 참고한 이미지, ChechkCamera 테스트용 카메라, 흰박스 (Floor, Wall, Platforms로 했으나 차이x)
- (Sorting Layers)BackGround, MiddleGround, ForeGround1~3으로 이미지 배치중, Player : 스프라이트 한장 크기확인용
