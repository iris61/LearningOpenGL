#version 330 core
out vec4 FragColor;
in vec3 vColor;

uniform vec4 timeColor;

void main()
{
//    FragColor = vec4(vColor.x * timeColor.x, vColor.y * timeColor.y, vColor.z * timeColor.z, timeColor.w);
    FragColor = vec4(vColor, 1.0);
}
