extern "C" void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_SharedInternals();
	RegisterModule_SharedInternals();

	void RegisterModule_Core();
	RegisterModule_Core();

	void RegisterModule_AI();
	RegisterModule_AI();

	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_InputLegacy();
	RegisterModule_InputLegacy();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

	void RegisterModule_ParticleSystem();
	RegisterModule_ParticleSystem();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_RuntimeInitializeOnLoadManagerInitializer();
	RegisterModule_RuntimeInitializeOnLoadManagerInitializer();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_TextCore();
	RegisterModule_TextCore();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_WebGL();
	RegisterModule_WebGL();

}

template <typename T> void RegisterUnityClass(const char*);
template <typename T> void RegisterStrippedType(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

namespace ObjectProduceTestTypes { class Derived; } 
namespace ObjectProduceTestTypes { class SubDerived; } 
class EditorExtension; template <> void RegisterUnityClass<EditorExtension>(const char*);
namespace Unity { class Component; } template <> void RegisterUnityClass<Unity::Component>(const char*);
class Behaviour; template <> void RegisterUnityClass<Behaviour>(const char*);
class Animation; 
class Animator; template <> void RegisterUnityClass<Animator>(const char*);
namespace Unity { class ArticulationBody; } 
class AudioBehaviour; template <> void RegisterUnityClass<AudioBehaviour>(const char*);
class AudioListener; template <> void RegisterUnityClass<AudioListener>(const char*);
class AudioSource; template <> void RegisterUnityClass<AudioSource>(const char*);
class AudioFilter; 
class AudioChorusFilter; 
class AudioDistortionFilter; 
class AudioEchoFilter; 
class AudioHighPassFilter; 
class AudioLowPassFilter; 
class AudioReverbFilter; 
class AudioReverbZone; 
class Camera; template <> void RegisterUnityClass<Camera>(const char*);
namespace UI { class Canvas; } template <> void RegisterUnityClass<UI::Canvas>(const char*);
namespace UI { class CanvasGroup; } template <> void RegisterUnityClass<UI::CanvasGroup>(const char*);
namespace Unity { class Cloth; } 
class Collider2D; 
class BoxCollider2D; 
class CapsuleCollider2D; 
class CircleCollider2D; 
class CompositeCollider2D; 
class EdgeCollider2D; 
class PolygonCollider2D; 
class TilemapCollider2D; 
class ConstantForce; 
class Effector2D; 
class AreaEffector2D; 
class BuoyancyEffector2D; 
class PlatformEffector2D; 
class PointEffector2D; 
class SurfaceEffector2D; 
class FlareLayer; 
class GridLayout; 
class Grid; 
class Tilemap; 
class Halo; template <> void RegisterUnityClass<Halo>(const char*);
class HaloLayer; 
class IConstraint; 
class AimConstraint; 
class LookAtConstraint; 
class ParentConstraint; 
class PositionConstraint; 
class RotationConstraint; 
class ScaleConstraint; 
class Joint2D; 
class AnchoredJoint2D; 
class DistanceJoint2D; 
class FixedJoint2D; 
class FrictionJoint2D; 
class HingeJoint2D; 
class SliderJoint2D; 
class SpringJoint2D; 
class WheelJoint2D; 
class RelativeJoint2D; 
class TargetJoint2D; 
class LensFlare; 
class Light; template <> void RegisterUnityClass<Light>(const char*);
class LightProbeGroup; 
class LightProbeProxyVolume; 
class MonoBehaviour; template <> void RegisterUnityClass<MonoBehaviour>(const char*);
class NavMeshAgent; template <> void RegisterUnityClass<NavMeshAgent>(const char*);
class NavMeshObstacle; template <> void RegisterUnityClass<NavMeshObstacle>(const char*);
class OffMeshLink; template <> void RegisterUnityClass<OffMeshLink>(const char*);
class ParticleSystemForceField; 
class PhysicsUpdateBehaviour2D; 
class ConstantForce2D; 
class PlayableDirector; 
class Projector; 
class ReflectionProbe; template <> void RegisterUnityClass<ReflectionProbe>(const char*);
class Skybox; 
class SortingGroup; 
class StreamingController; 
class Terrain; 
class VideoPlayer; 
class VisualEffect; 
class WindZone; 
namespace UI { class CanvasRenderer; } template <> void RegisterUnityClass<UI::CanvasRenderer>(const char*);
class Collider; template <> void RegisterUnityClass<Collider>(const char*);
class BoxCollider; template <> void RegisterUnityClass<BoxCollider>(const char*);
class CapsuleCollider; template <> void RegisterUnityClass<CapsuleCollider>(const char*);
class CharacterController; template <> void RegisterUnityClass<CharacterController>(const char*);
class MeshCollider; template <> void RegisterUnityClass<MeshCollider>(const char*);
class SphereCollider; template <> void RegisterUnityClass<SphereCollider>(const char*);
class TerrainCollider; 
class WheelCollider; 
class FakeComponent; 
namespace Unity { class Joint; } template <> void RegisterUnityClass<Unity::Joint>(const char*);
namespace Unity { class CharacterJoint; } template <> void RegisterUnityClass<Unity::CharacterJoint>(const char*);
namespace Unity { class ConfigurableJoint; } 
namespace Unity { class FixedJoint; } 
namespace Unity { class HingeJoint; } 
namespace Unity { class SpringJoint; } 
class LODGroup; 
class MeshFilter; template <> void RegisterUnityClass<MeshFilter>(const char*);
class OcclusionArea; 
class OcclusionPortal; 
class ParticleSystem; template <> void RegisterUnityClass<ParticleSystem>(const char*);
class Renderer; template <> void RegisterUnityClass<Renderer>(const char*);
class BillboardRenderer; 
class LineRenderer; 
class RendererFake; 
class MeshRenderer; template <> void RegisterUnityClass<MeshRenderer>(const char*);
class ParticleSystemRenderer; template <> void RegisterUnityClass<ParticleSystemRenderer>(const char*);
class SkinnedMeshRenderer; template <> void RegisterUnityClass<SkinnedMeshRenderer>(const char*);
class SpriteMask; 
class SpriteRenderer; 
class SpriteShapeRenderer; 
class TilemapRenderer; 
class TrailRenderer; 
class VFXRenderer; 
class Rigidbody; template <> void RegisterUnityClass<Rigidbody>(const char*);
class Rigidbody2D; 
namespace TextRenderingPrivate { class TextMesh; } 
class Transform; template <> void RegisterUnityClass<Transform>(const char*);
namespace UI { class RectTransform; } template <> void RegisterUnityClass<UI::RectTransform>(const char*);
class Tree; 
class GameObject; template <> void RegisterUnityClass<GameObject>(const char*);
class NamedObject; template <> void RegisterUnityClass<NamedObject>(const char*);
class AssetBundle; 
class AssetBundleManifest; 
class AudioMixer; template <> void RegisterUnityClass<AudioMixer>(const char*);
class AudioMixerController; 
class AudioMixerGroup; template <> void RegisterUnityClass<AudioMixerGroup>(const char*);
class AudioMixerGroupController; 
class AudioMixerSnapshot; template <> void RegisterUnityClass<AudioMixerSnapshot>(const char*);
class AudioMixerSnapshotController; 
class Avatar; template <> void RegisterUnityClass<Avatar>(const char*);
class AvatarMask; 
class BillboardAsset; 
class ComputeShader; template <> void RegisterUnityClass<ComputeShader>(const char*);
class Flare; 
namespace TextRendering { class Font; } template <> void RegisterUnityClass<TextRendering::Font>(const char*);
class LightProbes; template <> void RegisterUnityClass<LightProbes>(const char*);
class LightingSettings; template <> void RegisterUnityClass<LightingSettings>(const char*);
class LocalizationAsset; 
class Material; template <> void RegisterUnityClass<Material>(const char*);
class ProceduralMaterial; 
class Mesh; template <> void RegisterUnityClass<Mesh>(const char*);
class Motion; template <> void RegisterUnityClass<Motion>(const char*);
class AnimationClip; template <> void RegisterUnityClass<AnimationClip>(const char*);
class NavMeshData; template <> void RegisterUnityClass<NavMeshData>(const char*);
class OcclusionCullingData; 
class PhysicMaterial; 
class PhysicsMaterial2D; 
class PreloadData; template <> void RegisterUnityClass<PreloadData>(const char*);
class RayTracingShader; 
class RuntimeAnimatorController; template <> void RegisterUnityClass<RuntimeAnimatorController>(const char*);
class AnimatorController; template <> void RegisterUnityClass<AnimatorController>(const char*);
class AnimatorOverrideController; template <> void RegisterUnityClass<AnimatorOverrideController>(const char*);
class SampleClip; template <> void RegisterUnityClass<SampleClip>(const char*);
class AudioClip; template <> void RegisterUnityClass<AudioClip>(const char*);
class Shader; template <> void RegisterUnityClass<Shader>(const char*);
class ShaderVariantCollection; 
class SpeedTreeWindAsset; 
class Sprite; template <> void RegisterUnityClass<Sprite>(const char*);
class SpriteAtlas; template <> void RegisterUnityClass<SpriteAtlas>(const char*);
class SubstanceArchive; 
class TerrainData; 
class TerrainLayer; 
class TextAsset; template <> void RegisterUnityClass<TextAsset>(const char*);
class MonoScript; template <> void RegisterUnityClass<MonoScript>(const char*);
class Texture; template <> void RegisterUnityClass<Texture>(const char*);
class BaseVideoTexture; 
class WebCamTexture; 
class CubemapArray; template <> void RegisterUnityClass<CubemapArray>(const char*);
class LowerResBlitTexture; template <> void RegisterUnityClass<LowerResBlitTexture>(const char*);
class ProceduralTexture; 
class RenderTexture; template <> void RegisterUnityClass<RenderTexture>(const char*);
class CustomRenderTexture; 
class SparseTexture; 
class Texture2D; template <> void RegisterUnityClass<Texture2D>(const char*);
class Cubemap; template <> void RegisterUnityClass<Cubemap>(const char*);
class Texture2DArray; template <> void RegisterUnityClass<Texture2DArray>(const char*);
class Texture3D; template <> void RegisterUnityClass<Texture3D>(const char*);
class VideoClip; 
class VisualEffectObject; 
class VisualEffectAsset; 
class VisualEffectSubgraph; 
class EmptyObject; 
class GameManager; template <> void RegisterUnityClass<GameManager>(const char*);
class GlobalGameManager; template <> void RegisterUnityClass<GlobalGameManager>(const char*);
class AudioManager; template <> void RegisterUnityClass<AudioManager>(const char*);
class BuildSettings; template <> void RegisterUnityClass<BuildSettings>(const char*);
class DelayedCallManager; template <> void RegisterUnityClass<DelayedCallManager>(const char*);
class GraphicsSettings; template <> void RegisterUnityClass<GraphicsSettings>(const char*);
class InputManager; template <> void RegisterUnityClass<InputManager>(const char*);
class MonoManager; template <> void RegisterUnityClass<MonoManager>(const char*);
class NavMeshProjectSettings; template <> void RegisterUnityClass<NavMeshProjectSettings>(const char*);
class Physics2DSettings; 
class PhysicsManager; template <> void RegisterUnityClass<PhysicsManager>(const char*);
class PlayerSettings; template <> void RegisterUnityClass<PlayerSettings>(const char*);
class QualitySettings; template <> void RegisterUnityClass<QualitySettings>(const char*);
class ResourceManager; template <> void RegisterUnityClass<ResourceManager>(const char*);
class RuntimeInitializeOnLoadManager; template <> void RegisterUnityClass<RuntimeInitializeOnLoadManager>(const char*);
class ScriptMapper; template <> void RegisterUnityClass<ScriptMapper>(const char*);
class StreamingManager; 
class TagManager; template <> void RegisterUnityClass<TagManager>(const char*);
class TimeManager; template <> void RegisterUnityClass<TimeManager>(const char*);
class UnityConnectSettings; 
class VFXManager; 
class LevelGameManager; template <> void RegisterUnityClass<LevelGameManager>(const char*);
class LightmapSettings; template <> void RegisterUnityClass<LightmapSettings>(const char*);
class NavMeshSettings; template <> void RegisterUnityClass<NavMeshSettings>(const char*);
class OcclusionCullingSettings; 
class RenderSettings; template <> void RegisterUnityClass<RenderSettings>(const char*);
class NativeObjectType; 
class PropertyModificationsTargetTestObject; 
class SerializableManagedHost; 
class SerializableManagedRefTestClass; 
namespace ObjectProduceTestTypes { class SiblingDerived; } 
class TestObjectVectorPairStringBool; 
class TestObjectWithSerializedAnimationCurve; 
class TestObjectWithSerializedArray; 
class TestObjectWithSerializedMapStringBool; 
class TestObjectWithSerializedMapStringNonAlignedStruct; 
class TestObjectWithSpecialLayoutOne; 
class TestObjectWithSpecialLayoutTwo; 

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 91 non stripped classes
	//0. NavMeshAgent
	RegisterUnityClass<NavMeshAgent>("AI");
	//1. NavMeshData
	RegisterUnityClass<NavMeshData>("AI");
	//2. NavMeshObstacle
	RegisterUnityClass<NavMeshObstacle>("AI");
	//3. NavMeshProjectSettings
	RegisterUnityClass<NavMeshProjectSettings>("AI");
	//4. NavMeshSettings
	RegisterUnityClass<NavMeshSettings>("AI");
	//5. OffMeshLink
	RegisterUnityClass<OffMeshLink>("AI");
	//6. AnimationClip
	RegisterUnityClass<AnimationClip>("Animation");
	//7. Animator
	RegisterUnityClass<Animator>("Animation");
	//8. AnimatorController
	RegisterUnityClass<AnimatorController>("Animation");
	//9. AnimatorOverrideController
	RegisterUnityClass<AnimatorOverrideController>("Animation");
	//10. Avatar
	RegisterUnityClass<Avatar>("Animation");
	//11. Motion
	RegisterUnityClass<Motion>("Animation");
	//12. RuntimeAnimatorController
	RegisterUnityClass<RuntimeAnimatorController>("Animation");
	//13. AudioBehaviour
	RegisterUnityClass<AudioBehaviour>("Audio");
	//14. AudioClip
	RegisterUnityClass<AudioClip>("Audio");
	//15. AudioListener
	RegisterUnityClass<AudioListener>("Audio");
	//16. AudioManager
	RegisterUnityClass<AudioManager>("Audio");
	//17. AudioMixer
	RegisterUnityClass<AudioMixer>("Audio");
	//18. AudioMixerGroup
	RegisterUnityClass<AudioMixerGroup>("Audio");
	//19. AudioMixerSnapshot
	RegisterUnityClass<AudioMixerSnapshot>("Audio");
	//20. AudioSource
	RegisterUnityClass<AudioSource>("Audio");
	//21. SampleClip
	RegisterUnityClass<SampleClip>("Audio");
	//22. Behaviour
	RegisterUnityClass<Behaviour>("Core");
	//23. BuildSettings
	RegisterUnityClass<BuildSettings>("Core");
	//24. Camera
	RegisterUnityClass<Camera>("Core");
	//25. Unity::Component
	RegisterUnityClass<Unity::Component>("Core");
	//26. ComputeShader
	RegisterUnityClass<ComputeShader>("Core");
	//27. Cubemap
	RegisterUnityClass<Cubemap>("Core");
	//28. CubemapArray
	RegisterUnityClass<CubemapArray>("Core");
	//29. DelayedCallManager
	RegisterUnityClass<DelayedCallManager>("Core");
	//30. EditorExtension
	RegisterUnityClass<EditorExtension>("Core");
	//31. GameManager
	RegisterUnityClass<GameManager>("Core");
	//32. GameObject
	RegisterUnityClass<GameObject>("Core");
	//33. GlobalGameManager
	RegisterUnityClass<GlobalGameManager>("Core");
	//34. GraphicsSettings
	RegisterUnityClass<GraphicsSettings>("Core");
	//35. Halo
	RegisterUnityClass<Halo>("Core");
	//36. InputManager
	RegisterUnityClass<InputManager>("Core");
	//37. LevelGameManager
	RegisterUnityClass<LevelGameManager>("Core");
	//38. Light
	RegisterUnityClass<Light>("Core");
	//39. LightingSettings
	RegisterUnityClass<LightingSettings>("Core");
	//40. LightmapSettings
	RegisterUnityClass<LightmapSettings>("Core");
	//41. LightProbes
	RegisterUnityClass<LightProbes>("Core");
	//42. LowerResBlitTexture
	RegisterUnityClass<LowerResBlitTexture>("Core");
	//43. Material
	RegisterUnityClass<Material>("Core");
	//44. Mesh
	RegisterUnityClass<Mesh>("Core");
	//45. MeshFilter
	RegisterUnityClass<MeshFilter>("Core");
	//46. MeshRenderer
	RegisterUnityClass<MeshRenderer>("Core");
	//47. MonoBehaviour
	RegisterUnityClass<MonoBehaviour>("Core");
	//48. MonoManager
	RegisterUnityClass<MonoManager>("Core");
	//49. MonoScript
	RegisterUnityClass<MonoScript>("Core");
	//50. NamedObject
	RegisterUnityClass<NamedObject>("Core");
	//51. Object
	//Skipping Object
	//52. PlayerSettings
	RegisterUnityClass<PlayerSettings>("Core");
	//53. PreloadData
	RegisterUnityClass<PreloadData>("Core");
	//54. QualitySettings
	RegisterUnityClass<QualitySettings>("Core");
	//55. UI::RectTransform
	RegisterUnityClass<UI::RectTransform>("Core");
	//56. ReflectionProbe
	RegisterUnityClass<ReflectionProbe>("Core");
	//57. Renderer
	RegisterUnityClass<Renderer>("Core");
	//58. RenderSettings
	RegisterUnityClass<RenderSettings>("Core");
	//59. RenderTexture
	RegisterUnityClass<RenderTexture>("Core");
	//60. ResourceManager
	RegisterUnityClass<ResourceManager>("Core");
	//61. RuntimeInitializeOnLoadManager
	RegisterUnityClass<RuntimeInitializeOnLoadManager>("Core");
	//62. ScriptMapper
	RegisterUnityClass<ScriptMapper>("Core");
	//63. Shader
	RegisterUnityClass<Shader>("Core");
	//64. SkinnedMeshRenderer
	RegisterUnityClass<SkinnedMeshRenderer>("Core");
	//65. Sprite
	RegisterUnityClass<Sprite>("Core");
	//66. SpriteAtlas
	RegisterUnityClass<SpriteAtlas>("Core");
	//67. TagManager
	RegisterUnityClass<TagManager>("Core");
	//68. TextAsset
	RegisterUnityClass<TextAsset>("Core");
	//69. Texture
	RegisterUnityClass<Texture>("Core");
	//70. Texture2D
	RegisterUnityClass<Texture2D>("Core");
	//71. Texture2DArray
	RegisterUnityClass<Texture2DArray>("Core");
	//72. Texture3D
	RegisterUnityClass<Texture3D>("Core");
	//73. TimeManager
	RegisterUnityClass<TimeManager>("Core");
	//74. Transform
	RegisterUnityClass<Transform>("Core");
	//75. ParticleSystem
	RegisterUnityClass<ParticleSystem>("ParticleSystem");
	//76. ParticleSystemRenderer
	RegisterUnityClass<ParticleSystemRenderer>("ParticleSystem");
	//77. BoxCollider
	RegisterUnityClass<BoxCollider>("Physics");
	//78. CapsuleCollider
	RegisterUnityClass<CapsuleCollider>("Physics");
	//79. CharacterController
	RegisterUnityClass<CharacterController>("Physics");
	//80. Unity::CharacterJoint
	RegisterUnityClass<Unity::CharacterJoint>("Physics");
	//81. Collider
	RegisterUnityClass<Collider>("Physics");
	//82. Unity::Joint
	RegisterUnityClass<Unity::Joint>("Physics");
	//83. MeshCollider
	RegisterUnityClass<MeshCollider>("Physics");
	//84. PhysicsManager
	RegisterUnityClass<PhysicsManager>("Physics");
	//85. Rigidbody
	RegisterUnityClass<Rigidbody>("Physics");
	//86. SphereCollider
	RegisterUnityClass<SphereCollider>("Physics");
	//87. TextRendering::Font
	RegisterUnityClass<TextRendering::Font>("TextRendering");
	//88. UI::Canvas
	RegisterUnityClass<UI::Canvas>("UI");
	//89. UI::CanvasGroup
	RegisterUnityClass<UI::CanvasGroup>("UI");
	//90. UI::CanvasRenderer
	RegisterUnityClass<UI::CanvasRenderer>("UI");

}
