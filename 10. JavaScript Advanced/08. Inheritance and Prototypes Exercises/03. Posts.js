function getPosts() {
    class Post {
        constructor (title, content){
            this.title = title
            this.content = content
        }

        toString() {
            return `Post: ${this.title}\nContent: ${this.content}\n`
        }
    }

    class SocialMediaPost extends Post {
        constructor (title, content, likes, dislikes) {
            super(title, content)
            this.likes = likes
            this.dislikes = dislikes
            this.comments = []
        }

        addComment(comment) {
            this.comments.push(comment)
        }

        toString() {
            let result = super.toString()
            result += `Rating: ${this.likes - this.dislikes}`

            if (this.comments.length > 0) {
                result += '\nComments:'
                for (const comment of this.comments) {
                    result += '\n'
                    result += ` * ${comment}`
                }    
            }
            return result
        }
    }

    class BlogPost extends Post {
        constructor(title, content, views) {
            super(title, content)
            this.views = views
        }

        view() {
            this.views++
            return this
        }

        toString() {
            return `${super.toString()}Views: ${this.views}`
        }
    }

    return {Post, SocialMediaPost, BlogPost}
}

let result = getPosts()
let post = new result.Post("Post", "Content");

console.log(post.toString());

// Post: Post
// Content: Content

let scm = new result.SocialMediaPost("TestTitle", "TestContent", 5, 10);
scm.addComment("1");
scm.addComment("2");
scm.addComment("3");
console.log(scm.toString());

let test = new result.BlogPost("TestTitle", "TestContent", 5);

test.view().view().view();
console.log(test.toString())
