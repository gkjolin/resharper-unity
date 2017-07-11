${ActionId:LineComment}

Shader "Unlit/SingleColor"
{
    SubShader
    {
        Pass { Blend Off }
        Pass { Blend SrcAlpha OneMinusSrcAlpha }
        Pass { Blend One One }
        // {caret}Pass { Blend One One, Zero SrcColor }
        Pass { Blend 2 One One }
        Pass { BlendOp Add }
        Pass { BlendOp 3 Sub }
        Pass { BlendOp 3 Min, Max }
        Pass { AlphaToMask On }
    }
}
