module.exports = function(grunt) {
    grunt.initConfig({
        "pkg": grunt.file.readJSON('package.json'),
        copy: {
            main: {
                files: [
                    {
                        expand: true,
                        src: ["App_Plugins/**"],
                        dest: 'Website/',
                        cwd: "uformsia.app/"
                    }
                ]
            }
        }
    });
    grunt.loadNpmTasks("grunt-contrib-copy");
    grunt.registerTask("default", ["copy"]);
};