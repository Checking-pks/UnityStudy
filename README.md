# Unity Study
## 유니티 기초 학습
- Object Movement
- Shooting Bullet
- Summon Enemy

---
### Object Movement
오브젝트를 움직이게 하는 방법에는 3가지가 있다.
1. transform.position을 직접 변경하여 오브젝트의 위치를 변경하는 방식
2. Rigidbody를 통하여 오브젝트에게 속도를 주는 방식
3. Rigidbody를 통하여 오브젝트에게 힘을 가하는 방식

### Shooting Bullet
씬을 실행하고 있을 때 물체를 생성하는 방식은 Instantiate()를 사용하여 생성한다.
이때, 물체의 position과 rotation을 설정해 주어야 한다.
이후 물체에게 방향을 정면으로 정해주고 힘을 가하여 앞으로 날아가도록 한다.

### Summon Enemy
Instantiate()를 통하여 적을 생성한다.
적이 플레이어를 따라오게 만드는 방법은 2가지가 있다.
1. 적의 transform과 플레이어의 transform을 통하여 Lerp를 통하여 중간 위치를 구해서 적용시켜준다.
2. NavMeshAgent를 통하여 월드의 NavMesh를 생성해 주고 그것을 기반으로 Target을 정해줘 이동하게 만든다.

위치 생성은 맵의 끝자락에 맞춰 Random을 돌려  랜덤한 가장자리에서 생성될 수 있도록 position을 설정해 준다.
