
varying vec3 v_position;
varying vec3 v_camera_position;

uniform samplerCube u_texture;

void main()
{
	vec3 dir = normalize(v_camera_position - v_position);
    gl_FragColor = textureCube(u_texture,dir);
}
