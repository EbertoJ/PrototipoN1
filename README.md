# ✈️ Skybound - Prototipo de Juego en Unity

**Skybound** es un prototipo de juego en Unity centrado en el control básico de un avión. El objetivo es simular de manera sencilla una experiencia de vuelo, con controles básicos, físicas simplificadas, y una interfaz mínima.

---

## 🎮 Controles

- **W**: Acelerar hacia adelante
- **A / D**: Movimiento lateral (izquierda/derecha)
- **Espacio (Space)**: Elevarse (si la velocidad es suficiente)
- **S**: Descender suavemente o retroceder si está en el suelo

---

## 🧠 Funcionalidades Implementadas

### 🔧 Mecánicas de Vuelo
- Movimiento hacia adelante controlado por aceleración progresiva.
- Subida solo permitida cuando hay suficiente velocidad (como en un avión real).
- Movimiento lateral limitado para dar sensación de dirección.
- Descenso manual y reversa (en tierra).

### 🧩 Física Simplificada
- Sistema de aceleración, frenado por arrastre (drag) y velocidad máxima.
- Elevación proporcional a la velocidad.
- Descenso más suave para mejorar la experiencia de vuelo.

### 🧭 Interfaz de Usuario
- **Velocímetro (TMP)** en pantalla que muestra la velocidad actual del avión.
- Sistema de velocidad actualizado en tiempo real mediante un script separado (`SpeedDisplay.cs`).

---

## 🧾 Scripts Incluidos

- `SimpleAirplaneController.cs`: Controlador principal del avión. Maneja entrada del usuario, físicas, elevación y movimiento.
- `SpeedDisplay.cs`: Script que muestra la velocidad del avión en un `TextMeshPro` dentro del Canvas de UI.

---

## 🖼️ Skybox y Escenario

- Skybox configurado desde los assets del Standard Assets o URP.
- Plano base o terreno 3D utilizado como superficie para pruebas de despegue y aterrizaje.

---

## ✅ Requisitos

- Unity (versión 2021 o superior recomendada)
- TextMeshPro (incluido por defecto desde Unity 2018+)
- Rigidbody en el avión (agregado automáticamente por `[RequireComponent]`)

---

## 📦 Pendiente / Posibles Mejoras

- Animaciones de hélices o efectos visuales.
- Sistema de altitud y HUD completo.
- Rutas de vuelo, obstáculos o misiones básicas.
- Menú principal y reinicio de escena.
- Mejoras en física de vuelo más realista (curvas de aceleración, resistencia del aire, etc).

---

## 👤 Autor

Desarrollado por **Eberto Jaime** como parte de un proyecto universitario/prototipo para *Skybound*.

