# Dark Rogue
cooperation TeamProject  웹툰 + 사운드 + 게임개발 + (AI)

## 프로젝트 소개
1. 장르 : 던전 rpg 로그라이트
2. 개발환경 : 유니티 2D 프로젝트 2020.03.28f
3. 주요 사용자 : 15세 이상
4. 구현 결과물
  - 1차 목표 PC
  - 2차 목표 Mobile
5. 개발 기간 및 기한 : 4월 4일 ~ 5월 1일
6. 팀원 : 김민서, 김규리, 임진철, 전경서, 최수일
7. 주요 레퍼런스 : 할로우 나이트
8. 게임 내 구현 목표 설정 필요
9. 백업 3중으로 해놓을 것 : 클라우드, SSD, 깃헙 등

## 역할 분담

### 작화
캐릭터 원화 :  진철  
나머지 요소들: 배경, UI 에셋 찾기

### 사운드
효과음, bgm 소리 효과 변형은 규리

### 게임 개발 
민서 경서 수일 

- 플레이어  : 민서
- 아이템/UI     : 경서 
- 맵/몹         : 수일
- UI : 진행 하면서 틈틈히 같이 해요

### PM : 경서
---

**유의사항**
변수명 : 카멜로 작성 부탁드려요.

---

// 게임 구성

게임 메인 씬(스타트)
튜토맵 1 (키 설명)
던전 맵 1개, 상점이 중간에 있는 식 (데드셀 참고)


---


**<< 개발 계획 >>**
- 수/금요일 중간점검 

- 0차(04.04~04.08) : 사전 준비 기간, 개발 계획 구상
- 1차(04.11~04.15) : 플레이어 이동 및 인벤토리, 맵 제작 구현, 사운드 소스 정리, 캐릭터 이미지 스프라이트 제작
- 2차(04.18~04.22) :  NPC 상점과 대화 기능, 플레이어 공격 이펙트 추가 및 몬스터 구현 및 테스트, 사운드 소스 구하기
- 3차(04.25~04.28) : 모든 기능 융합 및 빌드, 최적화 테스트
- 4차(04.29~04.30) : 2차 대단위 개발요소(추가기능 등) 확립 및 1차 대단위 개발요소 정리

### 게임 규칙   
1. 플레이어는 방향키로 이동을 하며 단축키를 적용하여 대쉬, 점프, 공격, 스킬 등을 사용합니다.
2. 기본적인 화면 구성은 플레이어의 정보창이 상시 화면 좌측 상단에 있으며, 체력과 플레이어 아이콘이 존재합니다.
3. 게임 플레이 형식은 몬스터를 잡고 재화를 얻어 아이템을 통해 스토리를 이어가는 방식으로 반복적인 플레이를 통해 진행됩니다.
4. 맵은 3가지로 구성되어 있으며 튜토리얼, 마을, 던전으로 구성됩니다.
5. NPC와 대화하거나 상점을 통해 거래를 할 수 있습니다.
6. 플레이어 캐릭터에는 스프라이트 이미지를 통해 애니메이션을 적용합니다.
7. 인벤토리에서는 장착아이템과 소지품목을 볼 수 있습니다.
8. 플레이어와 몬스터의 움직임과 관련해 오디오소스를 적용했습니다.
  (공격,죽음,이동 등)
9. 플레이어는 5개의 목숨을 가지고 시작하며 장애물에 충돌하거나 몬스터에게 피격 시 -1 씩 체력을 잃습니다. 0이 되면 캐릭터는 초기위치로 돌아갑니다.
10. 메뉴버튼을 추가하여 게임을 정지, 종료하거나 저장하는 기능을 구현합니다. 
11. 공격 및 이동 시 사운드가 재생됩니다.
