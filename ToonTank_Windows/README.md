# 🎮 Toon Tanks

**Toon Tanks** is a simple third-person action game developed using **Unreal Engine**.  
The player controls a tank and must destroy all enemy turrets while avoiding incoming attacks.

---

## 🛠️ Action Plan (for develop the game)

1 # 🚜 Player Tank Control
- The player controls a tank using keyboard or controller input.
- Movement includes:
  - Forward and backward motion
  - Rotation left and right
- A camera system is attached to the tank to provide smooth and responsive gameplay.

---

2 # 🎯 Enemy Turrets
- Enemy turrets continuously monitor their surroundings.
- When the player enters the detection range:
  - The turret detects the player
  - Rotates toward the target
  - Fires projectiles automatically

---

3 # 💣 Projectile Firing System
- Both the player tank and enemy turrets can fire projectiles.
- Projectiles:
  - Move at a defined speed
  - Detect collisions
  - Explode on impact
  - Apply damage to the target

---

4 # ❤️ Health, Damage & Destruction
- Each actor (Player Tank / Enemy Turret) has a health system.
- When hit:
  - Health is reduced
  - When health reaches zero, the actor is destroyed
- Destruction is accompanied by visual and audio effects.

---

5 # 🏆 Win & Lose Conditions with UI
- ✅ **Win Condition**:
  - All enemy turrets are destroyed
- ❌ **Lose Condition**:
  - The player tank is destroyed
- A simple UI system displays:
  - Win screen
  - Lose screen
  - Option to restart the game

---

6 # ✨ Special Effects
To enhance gameplay and visual feedback, the project includes:
- 💥 Particle effects for explosions
- 🔊 Sound effects for firing and destruction
- 📷 Camera shake for impactful hits

---

## 🚀 Project Goals
- Learn core Unreal Engine concepts:
  - Gameplay programming
  - Actors and Components
  - Collision and damage systems
  - Basic UI implementation
- Apply programming concepts in a practical game development project.

---

## 📌 Notes
- This project is created for educational purposes.
- Open to improvements and further development.

---

🎮 **Enjoy the game!**
