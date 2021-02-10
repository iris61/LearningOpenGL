#version 330 core
out vec4 FragColor;

in vec3 vColor;
in vec2 vTexture;

uniform sampler2D ourTexture;
uniform sampler2D ourTexture2;
uniform vec2 visible;

void main()
{
//    FragColor = texture(ourTexture, vTexture);
//    FragColor = texture(ourTexture, vTexture) * vec4(vColor, 1.0);
//    vec2 cond = vec2(vTexture.x / 2, vTexture.y / 2);
    FragColor = mix(texture(ourTexture, vTexture), texture(ourTexture2, vTexture), visible.x);
}
