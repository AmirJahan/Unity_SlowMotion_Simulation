# Unity Physics Simulations

A comprehensive Unity physics tutorial project demonstrating various physics concepts including slow motion effects, collisions, raycasting, and more.

## Overview

This educational project covers Unity's physics system through practical examples and interactive scenes. Features a prominent slow-motion effect along with demonstrations of rigidbodies, colliders, joints, and physics materials.

## Technologies

- **Engine**: Unity 2020.3.20f1
- **Language**: C#
- **Physics**: Unity Physics System (3D/2D)

## Topics Covered

### Core Physics (LONG COURSE folder)
- **Rigidbody Fundamentals**: Physics body setup and properties
- **3D Colliders**: Collision detection and boundaries
- **3D Joints**: Physical connections between objects
- **Continuous Collision**: Detection for fast-moving objects
- **Wheel Colliders**: Vehicle physics
- **Gravity Manipulation**: Custom gravity (including planetary)
- **Collision Events**: Response to collisions
- **Constraints**: Restricting object movement
- **Triggers**: Non-physical collision zones
- **Torque and Rotation**: Rotational physics
- **2D Effectors**: Platform, buoyancy, area effects
- **Raycasting**: Hit detection and shooting
- **Particle Collision**: Particle system interactions
- **Cloth Simulation**: Fabric physics
- **Physics Materials**: Friction and bounce

### Featured Effects
- **Slow Motion**: Toggle-able time dilation using `Time.timeScale`
- **Mine Field with Triggers**: Interactive trigger mechanics
- **Physics Material Demo**: Color-changing on collision

## Implementation

### Slow Motion Effect
```csharp
void ToggleSlowMotion() {
    if (isSlowMo) {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;
    } else {
        Time.timeScale = 0.2f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
    isSlowMo = !isSlowMo;
}
```

## Project Structure

```
Unity_SlowMotion_Simulation/
├── Assets/
│   ├── 09_Time and Slowmotion/    # Slow motion effect
│   ├── 12_Physics Material/        # Material properties
│   └── LONG COURSE/
│       ├── 01 - Rigid Body/
│       ├── 05_Gravity/
│       ├── 06 - Collision Events/
│       ├── 14 - Raycast/
│       └── ...
└── ProjectSettings/
```

## Requirements

- Unity 2020.3+

## License

MIT License

![Slow Motion Effect](https://github.com/AmirJahan/Unity_SlowMotion_Simulation/blob/main/slowmo.gif)
